# Magic-Shop
A magic item shop management tool designed for use in tabletop games.
Since it's written in C#, Requires Windows and Newest .Net Framework!

Instead of actually working on my DnD campaign, I've been working on a program that would assist when players want to visit a shop and stock up on items.

Usage:

    Open ReadingXML.exe
    Click "Read XML" and point it to the XML file to populate the store with items.
    Click "Randomize Quantities" to generate randomized quantities for the store items.



Binary and Source:

https://github.com/garylzimmer/Magic-Shop

Instead of, you know, actually working on my campaign...

I've been learning C# by making a simple store and shopping cart program for me to use in my campaign during shopping trips to the town.

How to download?

    Click the link above and download Magic Shop.exe
    (You'll have to click on View Raw to get the download to start)
    Also make sure you download the TestItems.xml in order to input some items

How to use?

    Upon first opening, the program will ask for the XML file you should have downloaded.
    After that, click "Generate Shop" and the item quantities will fill out based on the item rarities
    Then you can start buying items!
    Once you have finished buying items, you can enter how much GP your player has in "Starting GP".
    Hit "Calculate" and it will add all the prices up and tell you how much you have left.

Limitations and TODO

    Need to make it so the "Total in Cart" and "Ending GP" will update when adding or returning items, not just the calculate event.
    Potentially add new screen to make editing and saving the item XML file possible and easy.
