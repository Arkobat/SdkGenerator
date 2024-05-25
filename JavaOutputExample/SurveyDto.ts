package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class SurveyDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Title;
        @NotNull
    	private DateTime CreatedDate;
        @NotNull
    	private PersonDto Creator;
        @Nullable
    	private QuestionDto Questions;
        @Nullable
    	private PollDto Polls;
    
    
    
}