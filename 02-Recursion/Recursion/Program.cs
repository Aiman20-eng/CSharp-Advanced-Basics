using System;
using System.Collections.Generic;

class Department
{
    public string Name { get; set; }

    public List<Department> Children { get; set; } = new List<Department>();
}

class Program
{
    static void Main()
    {
        Department company = new Department
        {
            Name = "الشركة",

            Children =
            {
                new Department
                {
                    Name = "الإدارة",

                    Children =
                    {
                        new Department
                        {
                            Name = "الموارد البشرية"
                        },

                        new Department
                        {
                            Name = "المالية",

                            Children =
                            {
                                new Department
                                {
                                    Name = "الرواتب"
                                },

                                new Department
                                {
                                    Name = "المحاسبة"
                                }
                            }
                        },

                        new Department
                        {
                            Name = "القانونية"
                        }
                    }
                },

                new Department
                {
                    Name = "التقنية",

                    Children =
                    {
                        new Department
                        {
                            Name = "البرمجة",

                            Children =
                            {
                                new Department
                                {
                                    Name = "Backend"
                                },

                                new Department
                                {
                                    Name = "Frontend"
                                },

                                new Department
                                {
                                    Name = "Mobile"
                                }
                            }
                        },

                        new Department
                        {
                            Name = "الشبكات"
                        }
                    }
                }
            }
        };

        PrintDepartments(company);
    }
    static void PrintDepartments(Department department)
    {
        Console.WriteLine(department.Name);

        foreach (Department child in department.Children)
        {
            PrintDepartments(child);
        }
    }
}

     
