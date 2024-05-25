package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class TransactionDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private double Amount;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private BankAccountDto FromAccount;
        @NotNull
    	private BankAccountDto ToAccount;
    
    
    
}