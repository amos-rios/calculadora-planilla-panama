# Calculadora de Planilla (Panamá)

Aplicación de escritorio en C# que calcula las deducciones de ley y el salario
neto de un empleado a partir de su salario bruto, según los porcentajes
vigentes en Panamá.

## Qué problema resuelve

El cálculo manual de planilla es repetitivo y propenso a errores. Esta
aplicación recibe los datos del empleado y devuelve de forma inmediata:

- **Seguro Social** — 9.75% del salario bruto
- **Seguro Educativo** — 1.25% del salario bruto
- **Salario Neto** — salario bruto menos ambas deducciones

## Tecnologías

- C# (.NET Framework 4.7.2)
- Windows Forms
- Visual Studio

## Cómo ejecutarlo

1. Clonar el repositorio
2. Abrir el archivo de solución en Visual Studio
3. Ejecutar con `F5` (o Depurar → Iniciar depuración)

No requiere base de datos ni dependencias externas.

## Cómo está construido

La lógica de negocio está separada de la interfaz:

- **`Empleado.cs`** — clase con los atributos del empleado como campos
  privados y los métodos de cálculo (`CalcularSeguroSocial`,
  `CalcularSeguroEducativo`, `CalcularSalarioNeto`). Los porcentajes y las
  fórmulas viven aquí.
- **`Form1.cs`** — interfaz gráfica. Solo captura los datos, instancia un
  objeto `Empleado` y muestra los resultados. No contiene fórmulas.

Esta separación permite cambiar los porcentajes de deducción, o reutilizar la
clase `Empleado` en otro tipo de aplicación, sin tocar la interfaz.

## Qué aprendí con este proyecto

- Aplicar encapsulamiento: los datos del empleado son privados y solo se
  acceden a través de los métodos de la clase.
- Separar la lógica de negocio de la capa de presentación, en lugar de
  escribir todos los cálculos dentro del evento de un botón.
- Validar la entrada del usuario antes de convertir texto a número, para que
  la aplicación no falle ante datos vacíos o mal escritos.

---

Proyecto desarrollado como laboratorio del curso de programación.
