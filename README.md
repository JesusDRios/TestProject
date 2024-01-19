# Test Automation Demo

This is a short implementation of an Automation Test project based on the following requirements:

The test should access the Google page (http://google.com) and perform a search for the term
"Selenium HQ".
1. Wait until the search box and search button are visible.
2. Clear the search box, input the term "HCHB", and click the search button.
3. Make sure that hchb.com is displayed on the second row.
4. Navigate to the web site.
5. Assert that number and email address in the top left corner of the website equals 866-
535-4242 and info@hchb.com respectively.
6. Click on the ‘Request Demo’ button – top right corner of the screen.
7. Verify that app navigates to https://hchb.com/request-demo/ page.
8. Fill in all the mandatory fields but two (First and Last name, Email etc). Leave Service
offered and Captcha validator unchecked.
9. Click Submit button.
10. Verify that following validation errors are displayed on the page:
a. Please correct the errors below: header is displayed on top.
b. This field is required error displayed next to Services offered field.
c. Invalid CAPTCHA error displayed next to Captcha element.
11. Close the Browser.

## Prerequisites

Make sure you have the following installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download) - version 4.8.09032
- Other specific requirements if any

## Project Setup

1. Clone this repository:

   ```bash
   git clone https://github.com/JesusDRios/TestProject.git
   cd your-directory/TestProject
   ```

Running Tests
Open a terminal in the project directory.

Run the tests using the .NET command:
```
   dotnet test
```
