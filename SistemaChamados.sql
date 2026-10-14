-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Host: mariadb:3306
-- Tempo de geração: 14/10/2026 às 11:30
-- Versão do servidor: 12.3.3-MariaDB-ubu2404
-- Versão do PHP: 8.3.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `SistemaChamados`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `categorias`
--

CREATE TABLE `categorias` (
  `id_categoria` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

--
-- Despejando dados para a tabela `categorias`
--

INSERT INTO `categorias` (`id_categoria`, `nome`) VALUES
(6, 'Acesso'),
(1, 'Hardware'),
(4, 'Impressora'),
(3, 'Rede'),
(5, 'Sistema'),
(2, 'Software');

-- --------------------------------------------------------

--
-- Estrutura para tabela `chamados`
--

CREATE TABLE `chamados` (
  `id_chamado` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_equipamento` int(11) NOT NULL,
  `id_categoria` int(11) NOT NULL,
  `id_tecnico` int(11) NOT NULL,
  `descricao` varchar(500) NOT NULL,
  `prioridade` varchar(20) NOT NULL DEFAULT 'Média',
  `data_abertura` datetime NOT NULL DEFAULT current_timestamp(),
  `status` varchar(30) NOT NULL DEFAULT 'Aberto'
) ;

--
-- Despejando dados para a tabela `chamados`
--

INSERT INTO `chamados` (`id_chamado`, `id_usuario`, `id_equipamento`, `id_categoria`, `id_tecnico`, `descricao`, `prioridade`, `data_abertura`, `status`) VALUES
(1, 1, 1, 1, 1, 'Computador não liga', 'Urgente', '2026-10-08 11:36:40', 'Em andamento'),
(2, 2, 2, 2, 2, 'Sistema não abre', 'Média', '2026-10-08 11:36:40', 'Em andamento'),
(3, 3, 3, 4, 1, 'Impressora não imprime', 'Baixa', '2026-10-08 11:36:40', 'Aguardando'),
(4, 4, 4, 3, 3, 'Computador sem acesso à internet', 'Urgente', '2026-10-08 11:36:40', 'Aberto'),
(5, 5, 6, 1, 2, 'Notebook apresentando lentidão', 'Média', '2026-10-08 11:36:40', 'Resolvido'),
(7, 4, 6, 4, 1, 'hhhhtht', 'Média', '2026-10-13 12:23:27', 'Aberto');

-- --------------------------------------------------------

--
-- Estrutura para tabela `equipamentos`
--

CREATE TABLE `equipamentos` (
  `id_equipamento` int(11) NOT NULL,
  `patrimonio` varchar(50) NOT NULL,
  `tipo` varchar(50) NOT NULL,
  `descricao` varchar(200) DEFAULT NULL,
  `id_setor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

--
-- Despejando dados para a tabela `equipamentos`
--

INSERT INTO `equipamentos` (`id_equipamento`, `patrimonio`, `tipo`, `descricao`, `id_setor`) VALUES
(1, 'PC-ADM-03', 'Computador', 'Computador do setor administrativo', 1),
(2, 'PC-FIN-02', 'Computador', 'Computador do setor financeiro', 2),
(3, 'IMP-RH-01', 'Impressora', 'Impressora do RH', 3),
(4, 'PC-COM-05', 'Computador', 'Computador do setor comercial', 4),
(5, 'SW-TI-01', 'Switch', 'Switch principal da rede', 6),
(6, 'NOTE-PROD-01', 'Notebook', 'Notebook utilizado na produção', 5);

-- --------------------------------------------------------

--
-- Estrutura para tabela `historico_chamados`
--

CREATE TABLE `historico_chamados` (
  `id_historico` int(11) NOT NULL,
  `id_chamado` int(11) NOT NULL,
  `status_anterior` varchar(30) DEFAULT NULL,
  `status_novo` varchar(30) NOT NULL,
  `data_alteracao` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `setores`
--

CREATE TABLE `setores` (
  `id_setor` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

--
-- Despejando dados para a tabela `setores`
--

INSERT INTO `setores` (`id_setor`, `nome`) VALUES
(1, 'Administrativo'),
(4, 'Comercial'),
(2, 'Financeiro'),
(5, 'Produção'),
(3, 'Recursos Humanos'),
(6, 'TI');

-- --------------------------------------------------------

--
-- Estrutura para tabela `tecnicos`
--

CREATE TABLE `tecnicos` (
  `id_tecnico` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `email` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

--
-- Despejando dados para a tabela `tecnicos`
--

INSERT INTO `tecnicos` (`id_tecnico`, `nome`, `email`) VALUES
(1, 'Técnico 01', 'tecnico01@empresa.com'),
(2, 'Técnico 02', 'tecnico02@empresa.com'),
(3, 'Técnico 03', 'tecnico03@empresa.com');

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `email` varchar(150) DEFAULT NULL,
  `id_setor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_uca1400_ai_ci;

--
-- Despejando dados para a tabela `usuarios`
--

INSERT INTO `usuarios` (`id_usuario`, `nome`, `email`, `id_setor`) VALUES
(1, 'Ana Souza', 'ana@empresa.com', 1),
(2, 'Carlos Oliveira', 'carlos@empresa.com', 2),
(3, 'Mariana Santos', 'mariana@empresa.com', 3),
(4, 'João Silva', 'joao@empresa.com', 4),
(5, 'Pedro Costa', 'pedro@empresa.com', 5);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id_categoria`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices de tabela `chamados`
--
ALTER TABLE `chamados`
  ADD PRIMARY KEY (`id_chamado`),
  ADD KEY `id_usuario` (`id_usuario`),
  ADD KEY `id_equipamento` (`id_equipamento`),
  ADD KEY `id_categoria` (`id_categoria`),
  ADD KEY `id_tecnico` (`id_tecnico`);

--
-- Índices de tabela `equipamentos`
--
ALTER TABLE `equipamentos`
  ADD PRIMARY KEY (`id_equipamento`),
  ADD UNIQUE KEY `patrimonio` (`patrimonio`),
  ADD KEY `id_setor` (`id_setor`);

--
-- Índices de tabela `historico_chamados`
--
ALTER TABLE `historico_chamados`
  ADD PRIMARY KEY (`id_historico`),
  ADD KEY `id_chamado` (`id_chamado`);

--
-- Índices de tabela `setores`
--
ALTER TABLE `setores`
  ADD PRIMARY KEY (`id_setor`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices de tabela `tecnicos`
--
ALTER TABLE `tecnicos`
  ADD PRIMARY KEY (`id_tecnico`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Índices de tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id_usuario`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `id_setor` (`id_setor`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `chamados`
--
ALTER TABLE `chamados`
  MODIFY `id_chamado` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `equipamentos`
--
ALTER TABLE `equipamentos`
  MODIFY `id_equipamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `historico_chamados`
--
ALTER TABLE `historico_chamados`
  MODIFY `id_historico` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `setores`
--
ALTER TABLE `setores`
  MODIFY `id_setor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de tabela `tecnicos`
--
ALTER TABLE `tecnicos`
  MODIFY `id_tecnico` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `chamados`
--
ALTER TABLE `chamados`
  ADD CONSTRAINT `1` FOREIGN KEY (`id_usuario`) REFERENCES `usuarios` (`id_usuario`),
  ADD CONSTRAINT `2` FOREIGN KEY (`id_equipamento`) REFERENCES `equipamentos` (`id_equipamento`),
  ADD CONSTRAINT `3` FOREIGN KEY (`id_categoria`) REFERENCES `categorias` (`id_categoria`),
  ADD CONSTRAINT `4` FOREIGN KEY (`id_tecnico`) REFERENCES `tecnicos` (`id_tecnico`);

--
-- Restrições para tabelas `equipamentos`
--
ALTER TABLE `equipamentos`
  ADD CONSTRAINT `1` FOREIGN KEY (`id_setor`) REFERENCES `setores` (`id_setor`);

--
-- Restrições para tabelas `historico_chamados`
--
ALTER TABLE `historico_chamados`
  ADD CONSTRAINT `1` FOREIGN KEY (`id_chamado`) REFERENCES `chamados` (`id_chamado`);

--
-- Restrições para tabelas `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `1` FOREIGN KEY (`id_setor`) REFERENCES `setores` (`id_setor`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
