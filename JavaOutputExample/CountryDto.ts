package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class CountryDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private String Code;
        @Nullable
    	private AddressDto Addresses;
        @Nullable
    	private SchoolDto Schools;
        @Nullable
    	private HospitalDto Hospitals;
        @Nullable
    	private PersonDto Citizens;
    
    
    
}