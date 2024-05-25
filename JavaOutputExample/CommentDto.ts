package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class CommentDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Content;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private PersonDto Author;
        @NotNull
    	private ArticleDto Article;
        @Nullable
    	private TagDto Tags;
    
    
    
}