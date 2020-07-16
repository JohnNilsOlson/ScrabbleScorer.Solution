# _Scrabble Scorer_

#### _An App to score a scrabble word, 7.16.20_

#### By _**Micheal Hansen, Tyson Lackey and JohnNils Olson**_

## Description

_A console app that determines what a word is worth._

## Specifications

| Spec | Input | Output |
| :--- | :---: | ---: |
| Instance of ScrabbleScore object created with score of 0 and word = user entered string | "SCRABBLE" | "Score = 0", "UserWord = 'SCRABBLE'" |
| User Entered string must contain only alphabetic characters (a-zA-Z) | "cl0wns!" | "Please enter a valid word" |
| User Entered word is broken into an array of lower case letters | "SCRABBLE" | {"s","c","r","a","b","b","l","e"} |
| Letters (a,e,i,o,u,l,n,r,s,t) increase score by 1 | {"l","i","n","e"} | Score: 4 |
| Letters (d,g) increase score by 2 | {"d","o","g"} | Score: 5 |
| Letters (b,c,m,p) increase score by 3 | {"b","c","m","p"} | Score: 12 |
| Letters (f,h,v,w,y) increase score by 4 | {"f","h","v","w","y"} | Score: 20 |
| Letters (k) increase score by 5 | {"k"} | Score: 5 |
| Letters (j,x) increase score by 8 | {"j","x"} | Score: 16 |
| Letters (q,z) increase score by 10 | {"q","z"} | Score: 20 |


## Setup/Installation Requirements

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.

## Known Bugs

_None currently known_

## Support and contact details

_Please reach out through my GitHub account._

## Technologies Used

* _VSCode_
* _C# and .NET_

### License

Copyright (c) 2020 **_Micheal Hansen, Tyson Lackey, and JohnNils Olson_**

*Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:*

*The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.*

*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*