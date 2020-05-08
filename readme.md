*Project Idea:


I decided to create an application that had the possibility of expansion for POS integration or inventory management. I was inspired by work because after a long
day, nothing beats a tasty cocktail. This application would be useful if someone is interested in having an online drink data base which gives you the ability to 
filter by the glass or ingredients, and also shows a list of popular drinks. This could also be a great tool for a new bartender to reference when learning new drinks
or making drinks they are unfamiliar with the process to make it and ingredients involved. The application is called Cocktail Central, and I had fun learning Winforms, 
creating logos, and connecting the functionality with code, and accessing the data by making http request and parsing json files. 




****This was my original idea
For my final project I'm thinking about writing a program using WinForms where it will let a user input a file name, and gives them the option to see how different
algorthims affect their run time of their file. They can pick one of the algorithims that will show statistics like the run time, and the 
computational complexity. Additionally, if they choose all the alogorthims, it will return some sort of comparative visualization.I'm thinking the algorthims I want to chose
will include Bubble sort, insertion sort, merge sort, and quick sort. This is not definitive, but I feel like it will give me a good feel. I was inspired to do this as my project because 
I had an aha moment in CS 243 where we had to count the set of instructions, come up with an equation, and look at the improvements with just a few modifications to the code. I feel like this 
really gave me a strong understanding because we ended up with a 0(1) runtime because the input was independent of the number of instructions which was 9 (a constant). While this is not really relating 
to personal interest persay, it will be a cool application to get quick statistical information. 

Design Diary:


20/05/05

I completely scratched my program because I felt the functionality would be too simple, and it wasn't keeping me engaged. Instead I started looking for practical applications I would use, or I thought would be fun, engaging, and useful. I came up 
with the idea of an application that has the ability to filter drinks, by specific fields. I started looking at different libraries I could use to be able to interface with the API. I hunkered down and learned about Windforms, and surprisingly it has
a great ability to interface with Visual Sudio, and the results are much more immediate. I started designing on paper, and it took me approximatley 3 hours to work on design alone. I didn't want to rush to coding even though I feel like I'm behind in terms
of where I should be with progress. At this point in my desing process, I need to work through an algorithim that uses sets of data and finds the intersection of them. I figured arrays were the best data structure to use, so I'm working on how that will
look programatically. I have the GUI desgined, and I'm feeling much better about my project. I didn't want to loose hope because I was suffering with the creativity piece of this project. Much like writers block, I felt like I had designers block. Now that
the ball is rolling, and I feel more familiar with Windforms itself. I feel less intimidated about the work ahead of me in the next few days. I plan to do the meat and potatoes of the programming in the next few days, as I learn more about how the intergration
of the libraries will take place. 

2020/05/06


I have made so much progress in my Cocktail Central app, and I'm extremely proud of myself and really excited to see my final product. Today I worked on the true functionality of my code and getting the different parts connected together. 
Before I started coding, I was thinking of what data structure would be best for what I was trying to accomplish. The goal is to click on a drop down menu, and via an HTTP request, populate the information through a json file from the API. 
I thought an associative array would be best because I thought 2 D associative array would have been best because I thought it would be good to refer to the drink, and have the output. Dictionaries and associates arrays that I learned in CS 328 
seemed like a good fit, and given that I'm working on my own web page in Sharon's class, I wanted to see how it would translate in this class. When the 2 D array did not produce the output that I wanted, I tried a one demential array, and I think  
it will be easier to load from the json files. I learned about $_POST and $_GET in Sharon's class as well as json, so it's awesome that I'm able to put the skills that I have picked up in that class, and apply it to this project. I realized I was too 
focused on the data structure piece instead of just enjoying myself and having fun. This project, by far, has been the most rewarding experience since I began learning programming. I really suggest using Winforms or atleast introduce it because it really
helped keep me engaged because I could see the immidiate changes without having to spend tons of hours in Unity trying to figure out how to even load the game. I plan to get help figuring out the json library issue which I need to be able to appropriatley 
parse my data, and it put it into a readable format. 

2020/05/07

Today I was able to imlement all of the final touches. At the beginning of the day I had the programmed designed and I had the GUI set-up for the most part, but I had a bunch of stub functions I needed to complete, and HTTP
requests that I needed to connect to pull my desired json file, and get it parsed. The parsing issue was resolved with a help of a friend, and I' was able use that function outline several times. I built my intersection function
that took the drop down menu I created with the desired ingrediant type and the desired glass type. I also added a search function, but I wasn't able to get a shadow input box set up for the text. I got my list sorted in 
alphabetical order in both drop down menus, and I have 5 favorite drink pictures on the top of my application, and when you click on the picture it gathers the information about the drink via the http request. I had to add
variables for each of the ingrediants, so in therory if there are more than 6 ingrediants, it will only display the first 6. This was mainly for sizing and the real estae avaible on the GUI. I had some failures in getting
my search bar to correctly filter with the other two drop down features, but functionality wise and the two intersection searches, I feel good about. This was probably the most rewarding programming so far, and I'm really
glad I was able to get over the 'project idea' hump. I put ALOT of hours into this project, and I'm excited to see how I do. 