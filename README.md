# Magic-Shop
A magic item shop management tool designed for use in tabletop games.
Instead of actually working on my DnD campaign, I've been working on a program that would assist when players want to visit a shop and stock up on items.

Usage:

    Open ReadingXML.exe
    Click "Read XML" and point it to the XML file to populate the store with items.
    Click "Randomize Quantities" to generate randomized quantities for the store items.

The program is only about half functional at this time, but things that should work correctly are:

    Clicking item names should bring up their description.
    Clicking buy should add the item into the shopping cart.
    Clicking return should ONLY lower the quantity of the item and delete the row if there are none left, BUT NOT actually add the item back to the shop (It's where I stopped to debug the first part of the returning function).

The issue I'm having is that behavior for rebuying a returned item isn't working as expected and I have no idea what the problem in the code is. 
