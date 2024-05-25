package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class DepartmentDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private CompanyDto Company;
        @Nullable
    	private JobDto Jobs;
        @Nullable
    	private PersonDto Employees;
        @Nullable
    	private ForumDto InternalForum;
    
    
    
}