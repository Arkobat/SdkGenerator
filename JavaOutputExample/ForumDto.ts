package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class ForumDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Title;
        @Nullable
    	private ThreadDto Threads;
        @NotNull
    	private ActivityLogDto ActivityLog;
    
    
    
}