# CrowdEase
### Exposición Interoceptiva en Entornos Virtuales

Este proyecto recrea un viaje en TransMilenio en realidad virtual para ayudar a los usuarios a familiarizarse con estímulos intensos (ruido, movimiento, densidad de personas) mediante **exposición interoceptiva progresiva** en un entorno seguro.  
Fue desarrollado en Unity y diseñado para ejecutarse en **Meta Quest 2**.

---

## 📸 Imagen Representativa
(despues la agrego)

---

## 🚀 Tecnologías Usadas
- **Unity 2021.3.16f1**
- **XR Interaction Toolkit 3.0.1**
- **OpenXR (PC y Android)**
- **Oculus / Meta Quest Runtime**
- Modelos y assets 3D (ciudad, bus, pasajeros)
- Scripts en **C#**

---

## 🧩 Descripción del Proyecto

El simulador permite experimentar un viaje en TransMilenio mientras se controla la intensidad de los estímulos internos y ambientales. El usuario puede:

- Activar el movimiento del entorno para simular desplazamiento.
- Aumentar progresivamente el número de pasajeros.
- Incrementar el ambiente sonoro realista del bus.
- Reiniciar la experiencia cuando lo desee.

Lo innovador del desarrollo fue implementar una **arquitectura sincronizada de estímulos** (densidad, sonido, movimiento) diseñada para apoyar procesos de **regulación emocional y adaptación gradual** a situaciones que pueden generar ansiedad en transporte público.

---

## 🧱 Características Principales
- Simulación de movimiento mediante desplazamiento del entorno.
- Sistema de densidad progresiva de pasajeros.
- Control del ambiente sonoro dinámico (volumen y realismo).
- Interacción mediante botones del control derecho (A / B).
- Optimizado para rendimiento en Meta Quest.

---

## 🕹️ Controles

La experiencia se controla completamente con los mandos de Meta Quest.  
A continuación se describen todas las interacciones disponibles:

### 🎮 Controlador Derecho

| Botón | Acción |
|-------|--------|
| **B** | Inicia la simulación: movimiento del entorno, aparición progresiva de pasajeros y aumento del sonido. |
| **A** | Reinicia la simulación y devuelve el entorno a su estado inicial (sin pasajeros y sin movimiento). |
| **Joystick Derecho** | No afecta el movimiento (el usuario permanece estable dentro del bus). |
| **Trigger / Grip** | No usados en esta versión (reservados para futuras funciones). |

### 🎮 Controlador Izquierdo

| Botón | Acción |
|-------|--------|
| **Joystick Izquierdo** | Permite moverse caminando dentro del bus (locomotion estándar del XR Toolkit). |
| **Trigger / Grip** | No usados actualmente. |

---

## 📦 Pre-requisitos

Antes de clonar el proyecto, instala:

- **Unity 2021.3.16f1**  
  https://unity3d.com/get-unity/download/archive

- **Android Build Support** en Unity  
  (incluye NDK, SDK y OpenJDK)

- **OpenXR Plugin**  
  (desde Project Settings → XR Plugin Management)

- **Meta Quest Developer Hub (opcional)**  
  para instalar el APK fácilmente en el visor.

---

## 📥 Instrucciones de Descarga (Desarrollo)

1. Clona el repositorio:
```bash
git clone https://github.com/tu-usuario/transmilenio-vr.git
```
2. Abre Unity Hub → Open Project → selecciona la carpeta clonada.

3. Asegúrate de que estén instalados los paquetes:

- XR Plugin Management

- OpenXR

- XR Interaction Toolkit 3.0.1

4. Selecciona la plataforma Android:
File → Build Settings → Android → Switch Platform

5. Conecta tu Quest y activa Developer Mode.

## ▶️ Instrucciones de Uso del Ejecutable (APK)

1. Instala el archivo .apk en tu visor:

- Con Meta Quest Developer Hub

- O vía ADB:
```bash
adb install transmilenioVR.apk
```

2.Abre la aplicación desde tu visor (Biblioteca → Unknown Sources).

3. Controles:

- Botón B → Iniciar simulación

- Botón A → Reiniciar simulación

- Movimiento: Joystick Izquierdo

4. Retorna al menú con el menú estándar de Oculus.

👥 Autor
- Daniel Roa Uribe

Estudiante de Ingeniería de Sistemas – Universidad de los Andes
