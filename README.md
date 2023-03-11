# TasKagitMakasOyunu
C# İle Yapılmış Basit Taş Kağıt Makas Oyunu

Öncelikle, oyunun amacı iki oyuncunun (kullanıcı ve bilgisayar) belirli bir sayıda raund oynamalarıdır. Her raundda, oyuncular Taş, Kağıt veya Makas seçeneklerinden birini seçerler. Ardından, seçimler karşılaştırılır ve bir kazanan belirlenir.

Bu Kodda, kullanıcının seçimi ComboBox üzerinden, bilgisayarın seçimi ise Random sınıfını kullanarak rastgele bir şekilde belirleniyor.

Kullanıcının seçimini belirlemek için ComboBox'ın SelectedIndex özelliği kullanıldı. Bu özellik, seçilen öğenin dizin numarasını (0'dan başlayarak) döndürür. Bu dizin numarası, TkmSecimleri enum'ındaki sabit değerlerle eşleştirilir ve kullanıcının seçimi belirlenir.

Bilgisayarın seçimini belirlemek için ise Random sınıfı kullanılır. Random.Next() metodu, belirtilen aralıkta (başlangıç ve bitiş değerleri arasında) rastgele bir tam sayı döndürür. Bu rastgele sayı, TkmSecimleri enum'ındaki sabit değerlerle eşleştirilir ve bilgisayarın seçimi belirlenir.

Daha sonra, kullanıcının seçimi ve bilgisayarın seçimi karşılaştırılır ve bir kazanan belirlenir. Bu karşılaştırma, bir if-else ifadesi kullanılarak yapılır.

Kazanan belirlendikten sonra, labellerla kazananın kim olduğu kullanıcıya bildirilir. Daha sonra, bir sonraki raund için tekrar seçim yapılması istenir.
