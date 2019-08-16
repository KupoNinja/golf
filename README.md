# Golf-Card

![](https://images.unsplash.com/photo-1532508583690-538a1436f423?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1952&q=80)

## Goals
<hr>
In this project students will demonstrate the ability to work with classes, create lists, and manage validation of user inputs. 

The goal of this application is to track Golf scores for a number of users over a predefined course. At the end scores are totaled and a winner is declared

## The Setup
<hr>

### Step 1
Users will need a list of courses to select from, so you will likely want to create a `Course` Class, to group all things related to each course into a single object. You will also likely want a class to manage each `Game` where you can add the course, and the list of players participating in that game. 

### Step 2
You will need to validate each peice of data provided by your users, to do this make sure to set up logical loops that will validate the users input, or propmt them to re-enter it. At no point should you app crash based on invalid input from the user. Be sure to use `Int32.TryParse()` and `ContainsKey()` to insure you are getting what you expect from your users.

## Requirements
<hr>

#### Visualization
- Users are provided with a list of courses to choose from
- Multiple courses are displayed for the user to select
- Total scores and the winner are displayed at the end of the game 
#### Functionality
- Gracefully handles bad input without crashing
- Users can add any number of players they wish
- Users will provide a score for each player on every hole
<hr>

### Stretch Goals (Requirements first! Then stretch goals.)
- At the end of a game, display the individual scores for each hole.
- Incorporate the ability to create new Golf Courses from the command line
- Allow users to provide a handicap when creating a player
- Display the over/under for each hole instead of the number of strokes