# Crust Credit App

A small Windows desktop app for recording store credit owed to customers at a pizza
store, replacing a paper list. Staff add a credit with the customer's name, phone number,
amount and a comment, then look it up later by name or phone number.

<!-- TODO: add screenshots of the Add Credit and Search tabs -->

## Features

- **Add credit**: name, phone number, amount and comments, with input checks so the phone
  and amount fields only accept numbers.
- **Search** by phone number or name as you type, with results in a grid.
- **Saved automatically** to a local JSON file when the app closes and reloaded on start.

Marking a credit as redeemed isn't built yet. The data model already records a redeemed
date for it.

## How it's built

- **C# WinForms** on .NET Framework 4.7.2.
- Credits are stored in `credits.json` (Newtonsoft.Json) next to the app. It holds
  customer details, so it's excluded from the repo.

## Running it

Open `CrustCreditApp.sln` in Visual Studio and run it.
