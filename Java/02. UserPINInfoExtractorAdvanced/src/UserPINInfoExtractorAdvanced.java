import PinClasses.Pin;

public class UserPINInfoExtractorAdvanced {

    public static void main(String[] args) {
        Pin myPin = new Pin("9204026666");
        System.out.println(myPin.getPinBirthday());
        System.out.println(myPin.getPinGender());
        System.out.println(myPin.getPinAge());
    }
    
}
