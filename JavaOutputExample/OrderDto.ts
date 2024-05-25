package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class OrderDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private DateTime OrderDate;
        @NotNull
    	private PersonDto Customer;
        @Nullable
    	private ProductDto Products;
        @NotNull
    	private double TotalAmount;
        @Nullable
    	private InvoiceDto Invoice;
    
    
    
}