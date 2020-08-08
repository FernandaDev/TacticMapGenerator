# Tactic Map Generator
This is a **simple tool** developed to create a **grid based map** for a tactic game. Look at this [video](https://youtu.be/ss9BFM6ULz8) to see an example.

The idea came while I was making a tactic strategy game and I decided to create a tool that could help me build and manage a grid based map.

### What I have learned with this project
Starting this project I didn't know much about **Costum Editor** and I had to learn some basic stuff and also I had to learn how to keep data persistent even when Unity gets restarted. 

Things that I learned:

- Make some fields to receive data(Grid size, prefab)
- Buttons to do some functionalities(Generate map, erase map, set walkable, set unwalkable)
- Make the buttons interactive or not based on some conditions
- Show warnings for necessary data
- Make the data persistent(I had a look into *EditorPrefs*, but ended up using *Scriptable Object* to store data)
