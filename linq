Linq enables us to query any type of data store(SQL Server,XML document,objects in memoery)

from student in dataContext.Students
where student.gender==="male"
select student;

Writing LINQ Queries
	there are two ways to write LINQ queries using 
	1.Lambda Expressions
	2.Sql Like query expressions
	IEnumerable<Student> students = Student.GetAllStudents()
	    .Where(student => student.Gender == "Male");
	or
Extension Methods
	-Extension methods enable you to "add" methods to existing types without
	  creating a new derived type,recompiling,or otherwise modifying the original type
	-Extension methods are a special kind of static method,but they are called
	 as if they were instance methods on the extended type

Aggregate operators
	Min
	   int smallestNumber = Numbers.Min();
           int smallestEvenNumber = Numbers.Where(n => n % 2 == 0).Min();
	Max
	Sum
	Count
	Average
	Aggregate
	         int result = Numbers.Aggregate((a, b) => a * b);
Restriction Operators
	Where : Where standard query operator belong to Restriction Operators
		IEnumerable<int> evenNumbers = numbers.Where(num => num % 2 == 0);
Projection Operators
	Select
		IEnumerable<int> employeeIds=Employee.GetAllEmployees()
		                              .Select(emp=>emp.EmployeeID)
	SelectMany
		it is used to project each element of a sequence to an IEnumerable<T> and flattens the 
		resulting sequences into one sequnece
Ordering Operators
	OrderBy
		 Student.GetAllStudents().OrderBy(s => s.Name);
		 from student in Student.GetAllStudents()
                   orderby student.Name
		   select student;
	OrderByDescending
	ThenBy
		Student.GetAllStudetns()
	    .OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenBy(s => s.StudentID);
	ThenByDescending
	Reverse
		IEnumerable<Student> result = students.Reverse();
partitioning Operators
	Take
	    it returns specified number of elements from the start of the collections
	    IEnumerable<string> result = countries.Take(3);
	Skip
	    Skip method skips a specified number of elements in a collection and then returns the remaining elements
	    IEnumerable<string> result = countries.Skip(3);
	TakeWhile
		it returns elements in a collection as long as given condition specified by the predicate is true
		IEnumerable<string> result = countries.TakeWhile(s => s.Length > 2);
	SkipWhile
		SkipWhile method skips elements in a collection as long as the given condition specified by the predicate is true, 
		and then returns the remaining elements.
		IEnumerable<string> result = countries.SkipWhile(s => s.Length > 2);
