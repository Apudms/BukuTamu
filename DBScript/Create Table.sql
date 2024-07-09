USE TamuSmartDB

-- Tabel Users
CREATE TABLE Users (
    user_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    username NVARCHAR(50) NOT NULL UNIQUE,
    password NVARCHAR(255) NOT NULL,
    email NVARCHAR(100) NOT NULL UNIQUE,
    full_name NVARCHAR(100),
    role NVARCHAR(10) DEFAULT 'user',
    created_by NVARCHAR(100),
    created_at DATETIME DEFAULT GETDATE(),
    updated_by NVARCHAR(100),
    updated_at DATETIME DEFAULT GETDATE(),
    row_status BIT DEFAULT 1
);

-- Tabel Events
CREATE TABLE Events (
    event_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    user_id UNIQUEIDENTIFIER,
    event_name NVARCHAR(100) NOT NULL,
    event_date DATE NOT NULL,
    event_location NVARCHAR(255),
    event_description NVARCHAR(MAX),
    created_by NVARCHAR(100),
    created_at DATETIME DEFAULT GETDATE(),
    updated_by NVARCHAR(100),
    updated_at DATETIME DEFAULT GETDATE(),
    row_status BIT DEFAULT 1,
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);

-- Tabel Guests
CREATE TABLE Guests (
    guest_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    event_id UNIQUEIDENTIFIER,
    full_name NVARCHAR(100) NOT NULL,
    email NVARCHAR(100),
    phone_number NVARCHAR(20),
    address NVARCHAR(255),
    created_by NVARCHAR(100),
    created_at DATETIME DEFAULT GETDATE(),
    updated_by NVARCHAR(100),
    updated_at DATETIME DEFAULT GETDATE(),
    row_status BIT DEFAULT 1,
    FOREIGN KEY (event_id) REFERENCES Events(event_id)
);

-- Tabel Invitations
CREATE TABLE Invitations (
    invitation_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    guest_id UNIQUEIDENTIFIER,
    event_id UNIQUEIDENTIFIER,
    status NVARCHAR(10) DEFAULT 'sent' CHECK (status IN ('sent', 'confirmed', 'declined')),
    sent_at DATETIME,
    confirmed_at DATETIME,
    created_by NVARCHAR(100),
    created_at DATETIME DEFAULT GETDATE(),
    updated_by NVARCHAR(100),
    updated_at DATETIME DEFAULT GETDATE(),
    row_status BIT DEFAULT 1,
    FOREIGN KEY (guest_id) REFERENCES Guests(guest_id),
    FOREIGN KEY (event_id) REFERENCES Events(event_id)
);

-- Tabel RSVP
CREATE TABLE RSVP (
    rsvp_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    guest_id UNIQUEIDENTIFIER,
    event_id UNIQUEIDENTIFIER,
    status NVARCHAR(15) DEFAULT 'maybe' CHECK (status IN ('yes', 'no', 'maybe')),
    notes NVARCHAR(MAX),
    created_by NVARCHAR(100),
    created_at DATETIME DEFAULT GETDATE(),
    updated_by NVARCHAR(100),
    updated_at DATETIME DEFAULT GETDATE(),
    row_status BIT DEFAULT 1,
    FOREIGN KEY (guest_id) REFERENCES Guests(guest_id),
    FOREIGN KEY (event_id) REFERENCES Events(event_id)
);

-- Tabel CheckIns
CREATE TABLE CheckIns (
    checkin_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    guest_id UNIQUEIDENTIFIER,
    event_id UNIQUEIDENTIFIER,
    checkin_time DATETIME DEFAULT GETDATE(),
    checkin_method NVARCHAR(10) DEFAULT 'manual' CHECK (checkin_method IN ('manual', 'qr_code', 'nfc', 'biometric')),
    created_by NVARCHAR(100),
    created_at DATETIME DEFAULT GETDATE(),
    updated_by NVARCHAR(100),
    updated_at DATETIME DEFAULT GETDATE(),
    row_status BIT DEFAULT 1,
    FOREIGN KEY (guest_id) REFERENCES Guests(guest_id),
    FOREIGN KEY (event_id) REFERENCES Events(event_id)
);

-- Tabel Gifts
CREATE TABLE Gifts (
    gift_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    guest_id UNIQUEIDENTIFIER,
    event_id UNIQUEIDENTIFIER,
    gift_description NVARCHAR(MAX) NOT NULL,
    gift_value DECIMAL(18, 2),
    created_by NVARCHAR(100),
    created_at DATETIME DEFAULT GETDATE(),
    updated_by NVARCHAR(100),
    updated_at DATETIME DEFAULT GETDATE(),
    row_status BIT DEFAULT 1,
    FOREIGN KEY (guest_id) REFERENCES Guests(guest_id),
    FOREIGN KEY (event_id) REFERENCES Events(event_id)
);

-- Tabel Settings
CREATE TABLE Settings (
    setting_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    user_id UNIQUEIDENTIFIER,
    notification_preferences NVARCHAR(MAX),
    language_preferences NVARCHAR(20) DEFAULT 'en',
    created_by NVARCHAR(100),
    created_at DATETIME DEFAULT GETDATE(),
    updated_by NVARCHAR(100),
    updated_at DATETIME DEFAULT GETDATE(),
    row_status BIT DEFAULT 1,
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);

-- Tabel Logs
CREATE TABLE Logs (
    log_id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    user_id UNIQUEIDENTIFIER,
    action NVARCHAR(MAX) NOT NULL,
    created_by NVARCHAR(100),
    created_at DATETIME DEFAULT GETDATE(),
    updated_by NVARCHAR(100),
    updated_at DATETIME DEFAULT GETDATE(),
    row_status BIT DEFAULT 1,
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);

