# APP NAME

#### _DESCRIPTION - BUILD DATE_

#### _By **Na Hyung Choi**_

## Description

DETAILED DESCRIPTION

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Computer chooses a random word from a list** | Start new game | Computer: "Make a guess!" _ _ _ _ _ _ _ _ (6 moves left)(word: Bagheera) |
| **Recognizes a wrong guess** | F | Wrong guess. _ _ _ _ _ _ _ _ |
| **Keeps track of wrong guesses** | F | Wrong guess. _ _ _ _ _ _ _ _ (5 moves left) Guesses Made: F |
| **Does not accept duplicate guesses** | F | You already guessed this letter. _ _ _ _ _ _ _ _ (5 moves left) Guesses Made: F |
| **Keeps track of number of wrong guesses** | F | Wrong guess. _ _ _ _ _ _ _ _ (5 moves left)|
| **Recognizes a correct guess** | A | Correct guess. _ _ _ _ _ _ _ _ |
| **Fills in guessed letter** | A | Correct guess. _ A _ _ _ _ _ A |
| **Determines loss** | 6 incorrect guesses | Game over! B A G H E E R A |
| **Determines win when all letters are filled in** | All letters filled in | You win! B A G H E E R A |
| **Determines win when correct word is manually entered** | I Know It!: bagheera | You win! B A G H E E R A |

## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone REPO URL HERE
    ```
2. Run the application
    ```
    $ dotnet run
    ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# / .NET

## Support and contact details

_Please contact Na Hyung with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Na Hyung Choi_**
