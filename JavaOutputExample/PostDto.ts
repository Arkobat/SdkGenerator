package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class PostDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Content;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private ThreadDto Thread;
        @NotNull
    	private PersonDto Author;
        @Nullable
    	private AchievementDto Achievement;
    
    
    
}