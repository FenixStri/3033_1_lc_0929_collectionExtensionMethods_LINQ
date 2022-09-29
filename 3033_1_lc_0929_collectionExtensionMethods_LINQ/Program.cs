// Fenix Strickland 1134371776
// mis 3033 001

using st;

List<Student> stuList;
stuList = new List<Student>();

Student stu;
stu = new Student() { name = "Fenix", age = 22, weight = 165};
stuList.Add(stu);
stu = new Student() { name = "Meg", age = 18, weight = 140 };
stuList.Add(stu);
stu = new Student() { name = "Stewie", age = 2, weight = 15 };
stuList.Add(stu);
stu = new Student() { name = "Bryan", age = 12, weight = 65 };
stuList.Add(stu);
stu = new Student() { name = "Peter", age = 44, weight = 265 };
stuList.Add(stu);
stu = new Student() { name = "Louise", age = 42, weight = 125 };
stuList.Add(stu);

// collection extension functions (use lambda sometimes)

var r1 = stuList.Min((Student s) => { return s.age; });
var r2 = stuList.Min((Student s) => { return s.weight; });
var r3 = stuList.MinBy((Student s) => { return s.weight; });

var r4 = stuList.Average((Student s) => { return s.age; });
var r5 = stuList.Average(s => s.weight);

var r6 = stuList.OrderBy(s => s.age); //ascending order by default (lowest to highest)
var r8 = stuList.OrderByDescending(s => s.age); //ascending order by default (lowest to highest)
var r7 = r6.ToList();

var r9 = stuList.Where(s =>  s.age > 20 && s.age < 25 ).ToList();

for(int i=0; i<r9.Count; i++)
{
    Console.WriteLine(r9[i].name);
    Console.WriteLine(r9[i]);
}

//anon datatype
//new {name = "", age=}

var r10 = stuList.Select((s) => { return new { na = s.name, age = s.age }; }).ToList();

var lr1 = from x in stuList
              //where x.age > 20 && x.age <25
          where x.name == "Fenix" || x.name == "Stewie"
          orderby x.age descending
           select new {name = x.name,w=x.weight};

var lr2 = lr1.ToList();

Console.ReadLine();
