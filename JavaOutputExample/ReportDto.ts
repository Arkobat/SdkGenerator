package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class ReportDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Title;
        @NotNull
    	private ComplaintDto Complaint;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private PersonDto Author;
        @Nullable
    	private String Summary;
        @Nullable
    	private RewardDto Reward;
    
    
    
}