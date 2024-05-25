package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class ArticleDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Title;
        @NotNull
    	private String Content;
        @NotNull
    	private PersonDto Author;
        @NotNull
    	private DateTime PublishedDate;
        @Nullable
    	private CommentDto Comments;
    
    
    
}