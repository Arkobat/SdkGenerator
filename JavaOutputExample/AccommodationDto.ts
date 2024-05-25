package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class AccommodationDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String HotelName;
        @NotNull
    	private AddressDto Location;
        @NotNull
    	private DateTime CheckInDate;
        @NotNull
    	private DateTime CheckOutDate;
        @NotNull
    	private PersonDto Guest;
    
    
    
}