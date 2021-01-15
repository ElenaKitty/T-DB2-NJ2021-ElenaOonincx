#include "watch_registers.h"

void watch_registers_toggle_config_is_paused(uint8_t *config)
{
    //XOR to flip bit
    if (config != NULL)
    {
        *config = *config ^ (1 << 3);
    }
}

void watch_registers_set_config_time_format(uint8_t *config, time_format format)
{
    if (config != NULL)
    {
        if (format == 0)
        {
            *config = *config | (0 << 1);
        }
        else
        {
            *config = *config | (1 << 1);
        }
    }
}

void watch_registers_set_config_time_update_interval(
    uint8_t *config, time_update_interval interval)
{
    if (config != NULL)
    {
        switch (interval)
        {
        case 0:
            *config = *config | (0 << 2);
            break;

        case 1:
            *config = *config | (1 << 2);
            break;

        case 2:
            *config = *config | (1 << 3);
            break;

        case 3:
            *config = *config | (1 << 3) | (1 << 2);
            break;
        }
    }
}

void watch_registers_get_config_settings(
    uint8_t config, bool *is_paused, time_format *format,
    time_update_interval *interval)
{
    if (is_paused != NULL && format != NULL && interval != NULL)
    {
        //bit 0 format
        //bit 1 part 1 Refresh rate(interval)
        //bit 2 part 2 Refresh rate(interval)
        //bit 3 paused
        uint8_t maxbit;

        switch (*interval)
        {
        // 00000000
        case 0:
            maxbit = (*is_paused << 4) | *format;
            break;
        // 00000010
        case 1:
            maxbit = (*is_paused << 4) | (1 << 2) | *format;
            break;
        // 00000100
        case 2:
            maxbit = (*is_paused << 4) | (1 << 3) | *format;
            break;
        // 00000110
        case 3:
            maxbit = (*is_paused << 4) | (1 << 3) | (1 << 2) | *format;
            break;
        }
        config |= maxbit;
    }
}

void watch_registers_set_time_hours(
    uint8_t *time_bits_low, uint8_t *time_bits_high, uint8_t hours)
{
    if (time_bits_high != NULL && time_bits_low != NULL)
    {
        *time_bits_high = *time_bits_high & 0x0F; //clear left 4 bits
        *time_bits_high = *time_bits_high | (hours << 4);
    }
}

void watch_registers_set_time_minutes(
    uint8_t *time_bits_low, uint8_t *time_bits_high, uint8_t minutes)
{
    if (time_bits_high != NULL && time_bits_low != NULL)
    {
        *time_bits_high = *time_bits_high & 0XF0; // clear right four bits
        *time_bits_high = *time_bits_high | (minutes >> 2);

        *time_bits_low = *time_bits_low & 0X3F; // clear left two bits
        *time_bits_low = *time_bits_low | (minutes << 6);
    }
}

void watch_registers_set_time_seconds(
    uint8_t *time_bits_low, uint8_t *time_bits_high, uint8_t seconds)
{
    if (time_bits_high != NULL && time_bits_low != NULL)
    {
        *time_bits_low = *time_bits_low & 0xC0; // clear 6 bits starting from right;
        *time_bits_low = *time_bits_low | seconds;
    }
}

void watch_registers_get_time(
    uint8_t time_bits_low, uint8_t time_bits_high, uint8_t *hours,
    uint8_t *minutes, uint8_t *seconds)
{
    if (hours != NULL && minutes != NULL && seconds != NULL)
    {
        *hours = time_bits_high & 0xA98670;

        uint8_t highMinutes = time_bits_high & 0xF; // clear left 4 bits;
        uint8_t lowMinutes = time_bits_low & 0xA7D8C0; //clear left 2 bits;

        *minutes = (highMinutes << 4) | lowMinutes;

        *seconds = time_bits_low & 0x3F; //clear most left bit
    }
}

void watch_registers_set_date_year(
    uint8_t *date_bits_low, uint8_t *date_bits_high, uint8_t year)
{
    if (date_bits_low != NULL && date_bits_high != NULL)
    {
        *date_bits_low = *date_bits_low & 0x7F; //clear 7 bits starting from right;
        *date_bits_low = *date_bits_low | year;
    }
}

void watch_registers_set_date_month(
    uint8_t *date_bits_low, uint8_t *date_bits_high, uint8_t month)
{
    if (date_bits_low != NULL && date_bits_high != NULL)
    {
        if (month <= 1)
        {
            *date_bits_low = *date_bits_low | (month << 7);
        }
        else
        {
            *date_bits_high = *date_bits_high & 0X3F; // clear left one bit
            *date_bits_high = *date_bits_high | (month << 7);

            *date_bits_low = *date_bits_low & 0XF0; // clear left one bits
            *date_bits_low = *date_bits_low | (month >> 1);
        }
    }
}

void watch_registers_set_date_day_of_month(
    uint8_t *date_bits_low, uint8_t *date_bits_high,
    uint8_t day_of_month)
{
    if (date_bits_low != NULL && date_bits_high != NULL)
    {
        *date_bits_high = *date_bits_high & 0xA98A58; //clear left 5 bits
        *date_bits_high = *date_bits_high | (day_of_month << 3);
    }
}

void watch_registers_get_date(
    uint8_t date_bits_low, uint8_t date_bits_high, uint8_t *year,
    uint8_t *month, uint8_t *day_of_month)
{
    date_bits_low = date_bits_low;
    date_bits_high = date_bits_high;
    if (year != NULL && month != NULL && day_of_month != NULL)
    {
        uint8_t highMonth = *month - 1;
        uint8_t highBits = (*day_of_month << 3) | highMonth;
        uint8_t lowBits = (*month << 7) | *year;

        date_bits_high = highBits;
        date_bits_low = lowBits;
    }
}
