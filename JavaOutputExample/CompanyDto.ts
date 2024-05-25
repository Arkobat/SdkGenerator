package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class CompanyDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private AddressDto Address;
        @Nullable
    	private JobDto Jobs;
        @Nullable
    	private PersonDto Employees;
        @Nullable
    	private ProjectDto Projects;
    
    
    
}