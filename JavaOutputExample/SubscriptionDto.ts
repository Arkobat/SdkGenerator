package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class SubscriptionDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String ServiceName;
        @NotNull
    	private DateTime StartDate;
        @Nullable
    	private DateTime EndDate;
        @NotNull
    	private PersonDto Subscriber;
    
    
    
}