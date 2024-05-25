package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class PaymentDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private double Amount;
        @NotNull
    	private DateTime PaymentDate;
        @NotNull
    	private InvoiceDto Invoice;
        @NotNull
    	private PersonDto Payer;
    
    
    
}