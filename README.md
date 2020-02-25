# ZARA TECH CHALLENGE
This challenge is part of the Vueling Training examens.  It consists in a investment calculator to know how much a client receive after selling all wallet stocks.

## Implementation
In this implementation, I tried apply Single Responsibility in the classes and methods. In a first moment, after I was analysed the challenge, I segregate the problem in tasks, which one was related with the actions necessaries for implement a solution for the investment calculator.

### 1. Planning
The first step was planning the tasks and important responsibilities to the implementation. Based on the Zara Challenge, I had three main questions:

> How I get read the quote per day present in the CSV file?
> How I get the last thursday of each month?
> How I get the opening quote of day after last thursday?

This main questions help me implement a investment calculator, which one return the total price after selling stocks.

### 2. Responsabilities

After think about the challenge and planning some structure and questions what I needed solve, I saw six main responsibilities:

 1. Management of the CSV file with the data stocks (to save in a object c#)
 2. Management of buy stocks date
 3. Management of quotes (opening and closing)
 4. Stocks Transactions (buy and sell)
 5. Wallet for stocks
 6. Return of the total price after selling the stocks wallet

### 3. The code
I tried apply the 10x10x10 rule and separated classes per responsibility.  For some classes I use Test Driven Development. Here I will explain a little bit about the classes.

#### *CsvReader.cs
CsvReader is responsible for management the stock data from a csv file (stocks-ITX.csv). Is able to read and to parse the data for the necessary type (basically two main types: *double* and *DataTime*).
#### *StockHistory.cs
StockHistory use a
#### *Quote.cs
#### *InvestmentDateCalculator.cs
#### *Broker.cs
#### *Investment.cs
#### *Wallet.cs
#### *Program.cs

## Improvement for the future
I think it is possible improve  the code in some aspects.

> Refactor the code: To make it more legible
> Apply the SOLID principle
> Work with exceptions
> Improve the information returned in the program

## Technology Stack

`C# | .NET FRAMEWORK | MSTest`