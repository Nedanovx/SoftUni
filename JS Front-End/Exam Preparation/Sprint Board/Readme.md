#Problem – Sprint Board

# Load the Board
Clicking the [Load Board] button on the top left should send a GET request to the server to fetch all sprint tasks in your local database. You have to add each task to its specified column list (ToDo, In Progress, Code Review, or Done). The tasks should have different text contents inside their respective buttons depending on which column they are in:
-	ToDo – “Move to In Progress”
-	In Progress – “Move to Code Review”
-	Code Review – “Move to Done”
-	Done – “Close”
Each Sprint task has the following HTML structure:

```ruby
<li class="task">
  <h3>Fix Bug</h3>
  <p>We have a new bug to fix</p>
  <button>Move to In Progress/Move to Code Review/Move to Done/Close</button>
</li>
```

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/aa6e6175-ed95-4663-907d-1d9203d46ca7)

#Add a Task
Clicking the [Add Task] button should send a POST request to the server creating a new task with a title and description from the input values (the status should have an initial value of 'ToDo'). After a successful creation, you should send another GET request to fetch all the tasks, including the newly added one into the ToDo column. You should also clear all input fields after the creation!

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/f839899b-2248-4aa3-85c0-5917846b5c36)


# Move a Task
Clicking the [Move] button on the individual tasks from the first 3 columns should move the task from one column to the next – from ToDo to In Progress to Code Review and finally to Done.</br>
After clicking the [Move] button, you should send a PATCH request to the server to modify the status of the changed item. After the successful request, you should fetch the items again and see that the change has been made.

# Close a Task
Clicking the [Close] button on the tasks in the Done section should send a DELETE request to the server and remove the item from your local database. After you’ve removed it successfully, fetch the items again.

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/9174c8c4-8cfa-4a60-a23c-ec833a634103)
