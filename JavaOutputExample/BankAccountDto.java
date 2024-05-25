/**
* Auto generated class
*/
 
package SchemaExtractor.Model.Example;
import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

public class BankAccountDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String AccountNumber;
        @NotNull
    	private double Balance;
        @NotNull
    	private PersonDto Owner;
        @Nullable
    	private TransactionDto Transactions;
    
    
    
}