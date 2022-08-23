# C-sharp-Assignment
mindbody training assignments aug22

# Date:08-Aug-2022

1. Take a Following String as Input
"The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny.

The character�also known by the code number 007 (pronounced "double-O-seven")�has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale (a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time."

Perform following Operations on the string by creating seperate methods for each of the following method call
- Print  Words Count 
- Print BlankSpace Count
- Print Digit Count
- Print Adverb Count
- Print count and indexes of 'the', 'is', 'to', 'As', 'of', 'in' 
- Find out the number of Statements in the above string
- Find out 'Special Characters' e.g. $, .,-, ; etc. used in the string and its position

2. Define an Array of Strings as follows
	string [] names = new string [] {"Ram", "Shankar", "Ramesh", "Vivek", "Satish", "Mukesh", "Sandeep", "Vinay", "Mahesh", "Tushar", "Tejas", "Suprotim", "Vikram", "Subodh", "Pravin", "Amit", "Ajit", "Anhijit", "Sharad", "Sanjay", "Vijay", "Abhay", "Vilas", "Anil", "Nandu", "Jaywant", "Shyam"};
- Perform Following Operations on it (Create a Seperate method for each of the following Task)
	- Print all String having length >= 7
	- Print all string starts with a Character parameter value passed to a method
		- PrintStartStartWith(char c){.....}
	- Print all string having odd length
	- Print All string having a character passed to the method in it
		- PrintContains(char c){.....}

# Date: 09-Aug-2022
1. From the CS_SimpleClass Project Modify the the StaffLogicList class by add follwing methods
	- Validate(Staff): This must be a Private method. This method will validate the Staff based on Following Rules
		- StaffId: MUST not be repeated
		- StaffName, Address, DeptName, StaffCategory, Ward,Room Must Not be Empty
		- The StaffCategoty value Must be one of the folowing
			- Doctor, Nurse, WardBoy, Technicain, Driver
		- The Ward value must be one of the following
			- General, Cancer, Heart, Critical Care
		- Numeric Values MUST not be -ve or 0
		- This method will be called while regitering new staff and updatring the staff. If the Validte() method return false, then the staff cannot be added or updated
	- Update Staff based on StaffId, Make sure that StaffId cannot be updated
		- First Search Record for Staff based on StaffId and if found then only update it
		- The List MUST maintain an index of Staff aftre update 
			- means: If the Staff recors is at 5th index before update then post update, it must be at 5th index only
	- Delete Staff based on StaffId must dele if the StaffId is present else shoe messsage that StaffId is not found
	- Add Following Mtehods
		- List Staff by StaffCategory
		- List Staff By DeptName
		- List Staff in Acsending order by StaffName
	- Add a Method to Calculate income for Each Staff bassed on Taxes, Feees, etc. (Modify the Staff class with additional income proeprties as per your analysys)

# 10-Aug-2022

1. Modify the DoctorLogic and NurseLogic class for Performing CRUD Operations
2. Very the following (Today)
	- Can we have protected and private abstract methods in abstract class
	- Can we override private or protected abstract methods of abstrat class using public method ode deribed class
	- Can we have private constructor, if yes then what is the use of it
	- Varify with self-Study
		- What is sealed class?
			- Can we have abstract method in sealed class?
			- Can we have protected method in sealed class?
		- Can we have 'static' constructor in abstract as well as sealed class?
	
# 11-Aug-2022
1. Modify the 08-Aug-2022 assignment 2 using Lambda Expressions 
2. Modify the First Assignment of Date 08-Aug-2022 by adding Extension methods for string
	- Yiu can use LINQ
3. From the EmployeeCollection Print Employee with Second Max Salary
4. From the EmployeeCollection Print Employee with Max and Min Salary Per Department


# Date 12-Aug-2022

1. USe the Employee Collection provided with this solution and perform the following operations on it in 3 Tasks
	- List all Employees in Ascending Order by Salary, Task 1
	- Continue to Task 2 to calculate Tax for each Employee
	- Contunue to Task 3 to Print All Employees with the EmpNo, EmpName, Salary, Tax fashion
2. Create a Dictionary of Employees by adding a Designation as a property into the Employee Record and hence in th Dictionary (With total records as min 40 including all keys) and perform following operations on Dictionary
	- Modify the Dictionay data by sorting each employee by EmpName
	- Show the Employee who is having Max.Salary per Key (DeptName) 
