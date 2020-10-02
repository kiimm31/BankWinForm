using BankLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Data.SQLite;

namespace BankLogic
{
    public class DatabaseFunctions : IDatabaseFunctions
    {
        private readonly string _connectionString;
        private readonly string _filePath;

        public DatabaseFunctions(string filePath)
        {
            _filePath = filePath;
            _connectionString = $"Data Source={_filePath}";
            InitialiseDatabase();
        }

        public void InitialiseDatabase()
        {
            using (IDbConnection connection = new SqliteConnection(_connectionString))
            {
                if (!File.Exists(_filePath))
                {
                    SQLiteConnection.CreateFile(_filePath);
                }


                string createBankAccountDB = $@"CREATE TABLE IF NOT EXISTS BankAccount (
	ID INTEGER PRIMARY KEY,
   	FirstName TEXT NOT NULL,
	LastName TEXT NOT NULL,
    Email TEXT NOT NULL UNIQUE,
	MobileNumber TEXT NOT NULL UNIQUE,
    IDNumber TEXT NOT NULL UNIQUE,
    DateOfBirth DATETIME NOT NULL,
    Address TEXT NOT NULL,
    BankAccountType INTEGER NOT NULL,
    IdentificationProofDocumentId INTEGER NOT NULL,
    AddressProofDocumentId INTEGER NOT NULL,
    IsDeleted INTEGER NOT NULL DEFAULT 0
)";
                string createDocumentDB = $@"CREATE TABLE IF NOT EXISTS Document (
	ID INTEGER PRIMARY KEY,
    HexString TEXT NOT NULL,
    Extension TEXT NOT NULL,
    IsDeleted INTEGER NOT NULL DEFAULT 0
)";
                string createTransactionDB = $@"CREATE TABLE IF NOT EXISTS BankTransaction (
	ID INTEGER PRIMARY KEY,
    TransactionDateTime DATETIME NOT NULL,
    BankAccountId INTEGER NOT NULL,
    TransactionAmount REAL NOT NULL,
    TransactionType INTEGAR NOT NULL,
    IsDeleted INTEGER NOT NULL DEFAULT 0
)";

                connection.Execute(createBankAccountDB);
                connection.Execute(createDocumentDB);
                connection.Execute(createTransactionDB);
            }
        }

        public int AddNewAccount(BankAccountDTO backAccountDTO)
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string insertQuery = $@"INSERT INTO BankAccount (FirstName,LastName,Email,MobileNumber,IDNumber,DateOfBirth,Address,BankAccountType,IdentificationProofDocumentId,AddressProofDocumentId,IsDeleted) 
VALUES ('{backAccountDTO.FirstName}', '{backAccountDTO.LastName}', '{backAccountDTO.Email}', '{backAccountDTO.MobileNumber}', '{backAccountDTO.IDNumber}','{backAccountDTO.DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss.fff")}','{backAccountDTO.Address}', '{(int)backAccountDTO.BankAccountType}','{backAccountDTO.IdentificationProofDocumentId}', '{backAccountDTO.AddressProofDocumentId}',0 );
SELECT last_insert_rowid();";

                int accountIdInserted = connection.QueryFirstOrDefault<int>(insertQuery);

                return accountIdInserted;
            }
        }

        public void AddNewTransaction(BankTransactionDTO bankTransactionDTO)
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string insertQuery = $@"INSERT INTO BankTransaction (TransactionDateTime,BankAccountId,TransactionAmount,TransactionType,IsDeleted) 
VALUES ('{bankTransactionDTO.TransactionDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff")}','{bankTransactionDTO.BankAccountId}',{bankTransactionDTO.TransactionAmount},{(int)bankTransactionDTO.TransactionType},0)";

                connection.Execute(insertQuery);
            }
        }

        public int AddNewDocument(DocumentDTO documentDTO)
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string insertQuery = $@"INSERT INTO Document (HexString,Extension,IsDeleted) VALUES ('{documentDTO.HexString}','{documentDTO.Extension}',0) ;
SELECT last_insert_rowid();";

                return connection.QueryFirstOrDefault<int>(insertQuery);
            }
        }

        public BankAccountDTO GetBackAccountDTO(int bankAccountId)
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string query = $@"SELECT * FROM BankAccount WHERE ID = {bankAccountId}";

                return connection.QueryFirstOrDefault<BankAccountDTO>(query);
            }
        }

        public DocumentDTO GetDocumentDTO(int documentId)
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string query = $@"Select * from DOCUMENT where ID = {documentId}";

                return connection.QueryFirstOrDefault<DocumentDTO>(query);
            }
        }

        public IEnumerable<BankTransactionDTO> GetBankTransactionDTOs(int bankAccountId)
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string query = $@"SELECT * FROM BankTransaction WHERE BankAccountId = {bankAccountId}";

                return connection.Query<BankTransactionDTO>(query);
            }
        }

        public IEnumerable<BankAccountDTO> GetAllBankAccount()
        {
            using (IDbConnection connection = new SQLiteConnection(_connectionString))
            {
                string query = $@"select 
ID
,FirstName
,LastName
,IDNumber
,DateOfBirth
,Address
,BankAccountType
,IdentificationProofDocumentId
,AddressProofDocumentId
,MobileNumber
,Email
,IsDeleted
from BankAccount
Where IsDeleted = 0";

                return connection.Query<BankAccountDTO>(query);
            }
        }
    }
}
