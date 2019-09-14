# case-grabber
A little command-line app to pull cases from https://case.law and explore them in a local database.


## Environment Variables needed to run

1. **CASELAW_KEY**
  * The API key from https://case.law used to make requests.  (need to register to get account)
2. **CASELAW_DBSTRING**
  * The db string for the local mariaDB.
  * Server=$(servername);User Id=$(userID);Password=$(password);Database=$(databaseName)
