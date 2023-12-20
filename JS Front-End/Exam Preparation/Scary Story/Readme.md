# Problem – Scary Story
Write the missing functionality of this user interface. The functionality is divided in the following steps: 

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/174603a9-7767-41a1-ad05-fc50d8caccf1)

**Your Task**

Write the missing JavaScript code to make the Scary Story work as expected:
All fields (First Name, Last Name, Age, Genre, Story title and Story text) are filled with the correct input
-	First Name, Last Name, Age, Story title and Story text are non-empty strings. If any of them is empty, the program should not do anything.

# 1. Getting the information from the form

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/c65ddd98-d771-4e66-af32-9bf17206ec4d)

-	On clicking the [“Publish”] button the information from the input fields is listed in the "preview" section. For the input fields a list item is added to the "preview-list" unordered list. 
-	The text format and order for each list item should be the same as on the picture below.  
-	When the button is clicked, the input fields must be cleared and the ["Publish"] button must be disabled. At the same time the "Save", "Edit" and the "Delete" buttons must be enabled.

The HTML structure looks like this:  

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/ec0d4a4a-b530-4945-80ec-2ec01e892686)

The functionality here is the following: 
-	When the "Edit" button is clicked, all of the information is loaded in the input fields from step 1 and all buttons in preview section are disabled while the ["Publish"] button is enabled again.

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/49e0023a-ca2b-470c-b2b2-580cb3cbd157)

-	The list items must be removed from the "preview-list" and all of the information must go back to the input fields again. 

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/b120266d-74a1-47b3-81bd-dd645b64313f)

-	When the "Save" button is clicked, the story is completed. For you, this means removing everything inside of the div with id = "main" and adding there only a \<h1\> tag. With message:  "Your scary story is saved!"

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/78a60627-f16d-49fb-a32d-3a74d5b0ebf4)

-	This is everything your webpage must contain at this step:

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/1717a7e6-7a47-460a-bec7-3ba17b232a5e)

  -	When the "Delete" button is clicked, the list item must be removed from the "preview-list" and the ["Publish"] button is enabled again.

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/1c1b027b-ef12-41a0-b3c0-cf79f96b0c49)



