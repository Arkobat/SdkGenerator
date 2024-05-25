package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class InvoiceDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private DateTime InvoiceDate;
        @NotNull
    	private OrderDto Order;
        @NotNull
    	private double Amount;
        @NotNull
    	private DateTime DueDate;
    
    
    
}