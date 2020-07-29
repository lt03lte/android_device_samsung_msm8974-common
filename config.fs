[AID_VENDOR_QCOM_DIAG]
value:2950

[AID_VENDOR_RFS]
value:2951

[AID_VENDOR_RFS_SHARED]
value:2952

[/system/bin/charger]
mode: 0755
user: AID_SYSTEM
group: AID_SYSTEM
caps: NET_BIND_SERVICE

[efs/]
mode: 0771
user: AID_SYSTEM
group: AID_RADIO
caps: 0

[firmware/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0

[firmware-modem/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0
