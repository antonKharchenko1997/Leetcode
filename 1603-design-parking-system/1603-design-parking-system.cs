public class ParkingSystem {
    public int[] spaces = new int[3];
    public ParkingSystem(int big, int medium, int small) {
        spaces[0] = big;
        spaces[1] = medium;
        spaces[2] = small;
    }
    
    public bool AddCar(int carType) {
        if(spaces[carType-1]!=0){
            spaces[carType-1]--;
            return true;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */