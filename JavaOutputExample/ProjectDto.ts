package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class ProjectDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @Nullable
    	private String Description;
        @Nullable
    	private PersonDto TeamMembers;
        @NotNull
    	private CompanyDto Company;
        @Nullable
    	private TaskDto Tasks;
    
    
    
}