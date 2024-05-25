/**
* Auto generated class
*/
 
package SchemaExtractor.Model.Example;
import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

public class PassportDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String PassportNumber;
        @NotNull
    	private PersonDto Holder;
        @NotNull
    	private DateTime IssueDate;
        @NotNull
    	private DateTime ExpiryDate;
        @Nullable
    	private VisaDto Visa;
    
    
    
}