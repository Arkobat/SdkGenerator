package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class FriendDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private ContactDto Friend;
        @NotNull
    	private DateTime FriendshipDate;
        @Nullable
    	private MessageDto Messages;
    
    
    
}