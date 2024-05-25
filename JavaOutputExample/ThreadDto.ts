package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class ThreadDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Title;
        @NotNull
    	private ForumDto Forum;
        @NotNull
    	private PersonDto Creator;
        @NotNull
    	private CategoryDto Category;
        @Nullable
    	private PostDto Posts;
    
    
    
}