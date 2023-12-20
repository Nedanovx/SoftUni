# Problem – Todo List

<h3>Load Tasks</h3>
Clicking the [Load All] button should send a GET request to the server to fetch all tasks in your local database.</br>
Each task is a list item in the following format:</br>
</br>

```ruby
<li>
  <span>Go Shopping</span>
  <button>Remove</button>
  <button>Edit</button>
</li>
```
</br>

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/a0b490d8-0814-44d2-bc9c-c8c307b23cf5)

<h3>Add Task</h3>
Clicking the [Add] button should send a POST request to server, creating a new task with the name from the input value and after the successful creation you should send another GET request to fetch all tasks, including the newly added one.

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/a8b95d9b-38dc-46d4-bb0d-8ba5dfa93d64)

<h3>Remove Task</h3>

Clicking the [Remove] button should send a DELETE request to the server and remove the item from your local database. After you’ve removed it successfully, fetch the items again.

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/2a36376f-4e63-4e8c-a7e0-866363efb09e)

<h3>Edit Task</h3>

Clicking the [Edit] button should change the DOM Structure for that list element, instead of a span you should create an input field with the current name as value and exchange the Edit button with a Submit button.
After clicking the [Submit] button you should send a PATCH request to the server to modify the name of the changed item, after the successful request you should fetch the items again and see that changes have been made.

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/5d9d82eb-7a49-49de-abf4-7ed5cfc8162b)

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/8052897d-5c1e-4e51-9d3a-ec759a8a2cfd)

![image](https://github.com/Nedanovx/SoftUni/assets/107359038/d811ae0f-871e-4c36-831f-e7b136456ec3)




