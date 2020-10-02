# BankWinForm


0. SqliteFilePath in BankWinForm Settings => store the destination of sqliteDB file
0.1 PublicEnum BankOverDraftLimit will contain dictionary of all account types's overdraft setting
1. initialise database -> create sqlDB if not there, create tables if not there.
2. AddAccount to create bank account
3. When creating account all field must be field. more validation can be filled in in BankWinForm.ValidUI()
4. upload all files to db for all the address and identity proof
5. select View Transaction to view history and Deposit/Wtihdraw
6. text box for amount input and click Deposit/Withdraw for action
7. To view document, press Download on mainpage and download to local to view.

#TODO
1. to implement Interest => TransactionType add one more Interest Enum
	add Background service to timer, end of month calculate interest and insert action
2. front end and back end is already separated, if web-base can just use bankLogic, and throw away winforms
and redo validation