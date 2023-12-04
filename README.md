# OnionArchitecture

## OnionArchitecture The Learning Process
Bu depo, Onion Architecture prensiplerine dayalı olarak geliştirilen basit bir uygulamayı içermektedir. Onion Architecture, yazılım projelerini modüler ve bağımsız katmanlara ayırmak için kullanılan bir tasarım desenidir. Bu depo, iş mantığı, veri erişimi ve kullanıcı arayüzü gibi farklı sorumlulukları ayrı katmanlarda barındıran bir yapıyı benimsemektedir.

## Proje Yapısı
- **Core**: Temel iş mantığı ve domain nesnelerini içeren çekirdek katmandır. Bu katman, diğer katmanlara bağımlı olmamalıdır.
- **Infrastructure**: Veritabanı erişimi, dış servis çağrıları gibi alt yapısal konuları ele alan katmandır. Dışa bağımlılıkları içerir.
- **Application**: Kullanıcı arayüzüyle iletişim kuran ve iş mantığına yönlendiren katmandır. Core ve Infrastructure katmanlarıyla etkileşimde bulunur.
- **Presentation**: Kullanıcı arayüzüyle doğrudan ilişkili olan katmandır. Web, masaüstü uygulamaları gibi çeşitli arayüzler içerebilir.

<img src="https://i.hizliresim.com/fwbmmax.png"  width="800px" target="_blank" />


