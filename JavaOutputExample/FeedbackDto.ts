package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class FeedbackDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Content;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private PersonDto Author;
        @NotNull
    	private SurveyDto Survey;
    
    
    
}