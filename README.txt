To run the program open the VerySecretiveRandomMusicSearchApp.sln in your Visual Studio and then compile and run the code.
To exit the applicaiton click escape on your keyboard.
Move the slider to select the number of words to be grabbed from the API.

Project is largely unfinished due to poor time management on my side.
I spent too much time on WPF element styles, instead of implementing logic first.
I had to give up on a few ideas that I had initially, e.g. using MVVM pattern for complete separation of data and GUI.

Here is a list of things I have implemented:
Number selection page (with minimum and maximum possible number)
Grabbing and storing the indicated number of words in a list from the API provided (with JSON deserialization)

Things I haven't done:
Checking words for uniqueness
Song view page
Song search by keywords
Grabbing and storing the songs from the database
Displaying the songs
