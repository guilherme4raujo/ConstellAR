Projeto da disciplina de Computação Gráfica
# ConstellAR (Unity) — Protótipo AR: Constellação de Órion

Aplicativo mobile (Android) em Realidade Aumentada (AR) construído no **Unity**, com foco em:
- Abrir a câmera com AR;
- Detectar plano (chão/superfície);
- Ao toque do usuário, posicionar um conteúdo virtual na cena;
- Exibir “marcadores” (esferas) e um texto informativo sobre a constelação de **Órion**.


## 1) Objetivo do Projeto

O projeto foi desenvolvido para demonstrar um fluxo AR básico:
1. Usuário abre o app;
2. A câmera é iniciada em modo AR (ARCore);
3. O usuário toca na tela;
4. O app coloca um “conteúdo virtual” na superfície detectada (ex.: constelação);
5. Ao tocar novamente, aparece um texto informativo.
6. <img width="1430" height="924" alt="image" src="https://github.com/user-attachments/assets/24fd7913-4ac6-417c-a2c4-b11497dbc236" />


---

## 2) Funcionalidades Implementadas

- ✅ Inicialização de AR e câmera no Android via AR Foundation + ARCore
- ✅ Raycast (toque na tela) para identificar superfície detectada
- ✅ Colocação de “prefab” (constelação) no ponto tocado
- ✅ Geração/posicionamento de esferas (marcadores) no espaço 3D
- ✅ Exibição de UI (texto) com descrição da constelação após interação

---

## 3) Tecnologias, Ferramentas e Pacotes

### 3.1 Ferramentas
- **Unity** (Editor + Unity Hub)
- **Android Build Support** (módulos do Unity) para gerar APK
- **Android SDK / NDK / JDK** (instalados via Unity Hub ou Android Studio, conforme ambiente)
- **Git** para versionamento
- **GitHub** para hospedagem do repositório

### 3.2 Pacotes Unity (Package Manager)
Este projeto usa principalmente:
- **AR Foundation** — base multiplataforma para AR (raycast, planos, câmera, tracking)
- **ARCore XR Plugin** — integração do Unity com o ARCore (Android)
- **XR Interaction / XR Origin** (dependendo da configuração do template) — estrutura de rig/câmera e tracking

Fontes oficiais:
- AR Foundation (Unity): https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@latest
- ARCore XR Plugin (Unity): https://docs.unity3d.com/Packages/com.unity.xr.arcore@latest
- Manual AR Foundation (Unity Learn / Docs): https://learn.unity.com/tutorial/arfoundation

### 3.3 Requisitos do dispositivo
- Android compatível com **ARCore**
- Permissão de **Câmera** habilitada

## 4) Estrutura do Repositório

Estrutura típica de projeto Unity (pastas principais):
- `Assets/`  
  Contém cenas, prefabs, scripts e recursos do projeto.
- `Packages/`  
  Define as dependências do projeto via Package Manager (manifest e versões).
- `ProjectSettings/`  
  Configurações do projeto (Player Settings, XR, Android, etc).

> Observação: pastas geradas automaticamente como `Library/`, `Temp/`, `Logs/` não devem subir no GitHub.

---
#Dificuldades do Projeto:
Infelizmente, enfrentei difuculdades na parte de detecção já que meu modelo precisa localizar um plano(Chão) e as métricas não funcioanm de forma adequada, como mostra as imagens abaixo:
<img width="738" height="1600" alt="image" src="https://github.com/user-attachments/assets/1b031586-d142-4860-a630-1a451bd2cdaa" />
<img width="738" height="1600" alt="image" src="https://github.com/user-attachments/assets/1a9f013e-e774-4e8d-8f89-ea5353b61aaa" />



