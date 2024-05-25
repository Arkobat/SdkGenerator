package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class JobDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Title;
        @Nullable
    	private String Description;
        @NotNull
    	private CompanyDto Company;
        @NotNull
    	private double Salary;
        @Nullable
    	private PersonDto Employees;
        @Nullable
    	private DepartmentDto Departments;
    
    
    
}