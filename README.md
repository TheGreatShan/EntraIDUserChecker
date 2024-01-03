# EntraID User Checker
## What's this tool
With this tool, you can check, if a or multiple users are active or disabled in your organization's EntraID(formerly known as Azure AD) tenant.
Please note, that this project was a solution a problem I faced and needed to fix quickly. This solution might have some warnings, errors and room for improvement.

### By cloning the git reposiotry
1. Clone the git repository: ```git clone https://github.com/TheGreatShan/EntraIDUserChecker.git```
2. Build the solution: ```dotnet build --configuration Release```
3. Copy the appsettings.template.json and fill out the missing parameters and rename the file to appsettings.json
4. Create a txt file with the upn's you want to test. Please have a look on the upn.template.txt file
5. Run the ADChecker.exe file

## Bt using the Releases
1. Download the current GitHub release
2. Copy the appsettings.template.json and fill out the missing parameters and rename the file to appsettings.json
3. Create a txt file with the upn's you want to test. Please have a look on the upn.template.txt file
4. Run the ADChecker.exe file
