package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class HabitDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String HabitName;
        @NotNull
    	private GoalDto Goal;
        @NotNull
    	private DateTime StartDate;
        @Nullable
    	private DateTime EndDate;
        @Nullable
    	private RoutineDto RoutineDto;
    
    
    
}