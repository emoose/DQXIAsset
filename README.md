# DQXIAsset
UAsset <-> CSV converter for DQXIS/UE4 DataTables, supporting almost all DQXIS table structs.

The UE4 package reading code here is pretty tightly coupled with the packages used by DQXIS, and not likely to work well with any other UE4 titles (unless they happened to be based on DQXIS's UE4 branch or something)

DQXIS datatables are kinda unique from other UE4 games datatables, instead of each row containing properties that describe each field name/type/value, rows instead have a single StructProperty inside them, which contains the row data pretty much as a C/C++ struct/binary blob.

Fortunately for us the format of these StructProperties is stored inside the EXE (as can be seen in [DQXIS-SDK](https://github.com/emoose/DQXIS-SDK)), though the format defined in the EXE doesn't always seem to match up with the actual row data, oftentimes having certain fields moved around/reordered, and padding fields added/removed.

There are a couple datatables in DQXIS that do use the normal UE4 datatable format though, these seem to be denoted by a "UDS" prefix ('user-defined struct').  
I've tried adding some support for these in here but it's not that great since I didn't design for that kind of table, you'd probably have better luck editing those with [kaiheilos's Uasset Viewer tool](https://github.com/kaiheilos/Utilities).

---

For info about using this tool see the Releases page: https://github.com/emoose/DQXIAsset/releases/
