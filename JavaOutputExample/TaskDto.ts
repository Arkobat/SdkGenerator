package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class TaskDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Title;
        @Nullable
    	private String Description;
        @NotNull
    	private PersonDto AssignedTo;
        @NotNull
    	private ProjectDto Project;
    
    
    
}