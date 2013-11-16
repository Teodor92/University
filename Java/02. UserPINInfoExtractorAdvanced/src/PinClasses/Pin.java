package PinClasses;

import java.util.Calendar;

public class Pin {

    private String pin;

    public Pin(String pin) {
        this.setPin(pin);
    }

    public String getPinGender() {
        String gender;
        int genderDigit = pin.charAt(pin.length() - 2);
        if (genderDigit % 2 == 0) {
            gender = "male";
        } else {
            gender = "female";
        }

        return gender;
    }

    public String getPinBirthday() {
        String bitrhDay = String.format(
                "Year: %d , Month: %d , Day: %d", getPinYear(), getPinMonth(), getPinDay());

        return bitrhDay;
    }

    public int getPinAge() {
        int age = Calendar.getInstance().get(Calendar.YEAR) - getPinYear();
        return age;
    }

    ;

    public int getPinYear() {
        int year = Integer.parseInt(this.pin.substring(0, 2));

        if (year < 14) {
            year += 2000;
        } else {
            year += 1900;
        }

        return year;
    }

    public int getPinDay() {
        int day = Integer.parseInt(pin.substring(4, 6));
        return day;
    }

    public int getPinMonth() {
        int month = Integer.parseInt(this.pin.substring(2, 4));
        return month;
    }

    private void setPin(String pin) {
        if (ValidatePin(pin) && tryParseLong(pin)) {
            this.pin = pin;
        } else {
            throw new IllegalArgumentException("Pin is invalid!");
        }
    }

    private boolean ValidatePin(String pin) {
        if (pin.length() != 10) {
            return false;
        } else {

            int month = Integer.parseInt(pin.substring(2, 4));

            if (month < 1 || month > 12) {
                return false;
            }

            int day = Integer.parseInt(pin.substring(4, 6));

            if (day < 1 || day > 31) {
                return false;
            }
        }

        return true;
    }

    private boolean tryParseLong(String value) {
        try {
            Long.parseLong(value);
            return true;
        } catch (NumberFormatException nfe) {
            return false;
        }
    }
}
