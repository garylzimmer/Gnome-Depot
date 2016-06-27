# Magic-Shop
A magic item shop management tool designed for use in tabletop games.
Since it's written in C#, Requires Windows and Newest .Net Framework!

Instead of actually working on my DnD campaign, I've been working on a program that would assist when players want to visit a shop and stock up on items.

Usage:

    Upon first opening, the program will ask for the XML file you should have downloaded.
    After that, click "Generate Shop" and the item quantities will fill out based on the item rarities
    Then you can start buying items!
    Once you have finished buying items, you can enter how much GP your player has in "Starting GP".
    Hit "Calculate" and it will add all the prices up and tell you how much you have left.

Limitations and TODO

    Need to make it so the "Total in Cart" and "Ending GP" will update when adding or returning items, not just the calculate event.
    Potentially add new screen to make editing and saving the item XML file possible and easy.
