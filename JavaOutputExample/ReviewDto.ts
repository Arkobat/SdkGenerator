package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class ReviewDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Content;
        @NotNull
    	private int Rating;
        @NotNull
    	private PersonDto Reviewer;
        @NotNull
    	private ProductDto Product;
    
    
    
}